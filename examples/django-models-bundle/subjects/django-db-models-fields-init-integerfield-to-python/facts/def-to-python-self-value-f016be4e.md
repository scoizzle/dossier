# Fact f016be4e

Store id: 324a9a9d-2cad-491c-977e-ec7b7f5bb2ac

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
- posted_at: `2026-11-09T23:44:50.1670840+00:00`

## Data

```json
{
  "end_line": 2230,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2220,
  "symbol": "IntegerField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2220,"selector":"L2220-L2230","symbol":"IntegerField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2230,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2220,
    "symbol": "IntegerField.to_python"
  },
  "id": "324a9a9d-2cad-491c-977e-ec7b7f5bb2ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1670840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2220,
        "selector": "L2220-L2230",
        "symbol": "IntegerField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "2ac66042-27e4-42d6-9c67-088a2babc969",
  "subject_name": "django/db/models/fields/__init__::IntegerField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
