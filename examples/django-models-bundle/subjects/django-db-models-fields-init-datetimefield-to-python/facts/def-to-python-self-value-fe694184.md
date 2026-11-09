# Fact fe694184

Store id: 2e9fe487-577d-4b16-a632-720ca2521706

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
- posted_at: `2026-11-09T23:44:50.1027200+00:00`

## Data

```json
{
  "end_line": 1688,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1637,
  "symbol": "DateTimeField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1637,"selector":"L1637-L1688","symbol":"DateTimeField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1688,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1637,
    "symbol": "DateTimeField.to_python"
  },
  "id": "2e9fe487-577d-4b16-a632-720ca2521706",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1027200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1637,
        "selector": "L1637-L1688",
        "symbol": "DateTimeField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "34562e12-e85e-40a5-b8e1-3f2b12a4e41f",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
