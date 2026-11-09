# Fact d9c8783e

Store id: f20b4d62-6b2a-4ef0-b5e1-d5c064208a37

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
- posted_at: `2026-11-09T23:31:56.6382860+00:00`

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
  "id": "f20b4d62-6b2a-4ef0-b5e1-d5c064208a37",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6382860+00:00"
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
  "subject_id": "5458ff46-db17-4b04-8043-750ecca43804",
  "subject_name": "django/db/models/fields/__init__::DecimalField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
