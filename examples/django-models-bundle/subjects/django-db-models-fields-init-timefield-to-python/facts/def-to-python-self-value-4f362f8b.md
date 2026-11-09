# Fact 4f362f8b

Store id: b7778f0b-e351-4c72-acdf-be28309d50ab

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
- posted_at: `2026-11-09T23:44:50.2587890+00:00`

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
  "id": "b7778f0b-e351-4c72-acdf-be28309d50ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2587890+00:00"
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
  "subject_id": "f1f0777c-b1c8-450d-ac2f-6e9e88ab4aae",
  "subject_name": "django/db/models/fields/__init__::TimeField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
