# Fact 4f362f8b

Store id: 2c44af32-8774-40ef-aee6-d237ae711f75

## Text

```text
def to_python(self, value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.6665860+00:00`

## Data

```json
{
  "end_line": 2686,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2660,
  "symbol": "TimeField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2660,"selector":"L2660-L2686","symbol":"TimeField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2686,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2660,
    "symbol": "TimeField.to_python"
  },
  "id": "2c44af32-8774-40ef-aee6-d237ae711f75",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6665860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2660,
        "selector": "L2660-L2686",
        "symbol": "TimeField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9f4b7784-78a5-4551-ba8e-47a950eb1223",
  "subject_name": "django/db/models/fields/__init__::TimeField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
