# Fact eb3a25c1

Store id: 40c6ea61-db1b-45c9-8723-3743057ea307

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
- posted_at: `2026-11-09T23:44:50.1561200+00:00`

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
  "id": "40c6ea61-db1b-45c9-8723-3743057ea307",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1561200+00:00"
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
  "subject_id": "4bade12d-3039-4534-a895-096f7cb57543",
  "subject_name": "django/db/models/fields/__init__::FloatField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
