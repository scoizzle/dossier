# Fact d9c8783e

Store id: 767a707c-917e-401a-9ef9-c8200da8ef04

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
- posted_at: `2026-11-09T23:44:50.1221240+00:00`

## Data

```json
{
  "end_line": 1913,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1893,
  "symbol": "DecimalField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1893,"selector":"L1893-L1913","symbol":"DecimalField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1913,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1893,
    "symbol": "DecimalField.to_python"
  },
  "id": "767a707c-917e-401a-9ef9-c8200da8ef04",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1221240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1893,
        "selector": "L1893-L1913",
        "symbol": "DecimalField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "31f5be43-8580-4b74-adae-bfda0248dd3f",
  "subject_name": "django/db/models/fields/__init__::DecimalField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
