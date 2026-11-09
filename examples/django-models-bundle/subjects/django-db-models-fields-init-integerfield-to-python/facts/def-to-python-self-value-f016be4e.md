# Fact f016be4e

Store id: e4a5e1da-d9c1-4428-9c44-7a5da6f15173

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
- posted_at: `2026-11-09T23:31:56.7046900+00:00`

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
  "id": "e4a5e1da-d9c1-4428-9c44-7a5da6f15173",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7046900+00:00"
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
  "subject_id": "37e33ccf-9387-460c-9a37-a97406520503",
  "subject_name": "django/db/models/fields/__init__::IntegerField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
