# Fact eb3a25c1

Store id: 8db51372-6355-4be5-aadb-16c1dbd843d8

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
- posted_at: `2026-11-09T22:39:42.5236290+00:00`

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
  "id": "8db51372-6355-4be5-aadb-16c1dbd843d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5236290+00:00"
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
  "subject_id": "e78d1ca6-2022-44b6-a99e-d5da5dd01936",
  "subject_name": "django/db/models/fields/__init__::FloatField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
