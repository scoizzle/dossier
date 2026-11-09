# Fact eb3a25c1

Store id: a154029c-5d8b-4371-9fbe-e1f9bdf8aadc

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
- posted_at: `2026-11-09T23:31:56.6892600+00:00`

## Data

```json
{
  "end_line": 2130,
  "entity_kind": "method",
  "parent": "FloatField",
  "start_line": 2120,
  "symbol": "FloatField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2120,"selector":"L2120-L2130","symbol":"FloatField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FloatField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2130,
    "entity_kind": "method",
    "parent": "FloatField",
    "start_line": 2120,
    "symbol": "FloatField.to_python"
  },
  "id": "a154029c-5d8b-4371-9fbe-e1f9bdf8aadc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6892600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2120,
        "selector": "L2120-L2130",
        "symbol": "FloatField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a75bded3-1291-4c12-bfc3-7eeaad84c43d",
  "subject_name": "django/db/models/fields/__init__::FloatField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
