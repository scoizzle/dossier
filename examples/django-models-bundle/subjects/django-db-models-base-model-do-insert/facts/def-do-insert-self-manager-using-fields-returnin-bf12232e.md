# Fact bf12232e

Store id: 038be281-26e7-4f4e-b09e-aef807582767

## Text

```text
def _do_insert(self, manager, using, fields, returning_fields, raw)
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
- posted_at: `2026-11-09T22:39:40.3422020+00:00`

## Data

```json
{
  "end_line": 1259,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1248,
  "symbol": "Model._do_insert"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1248,"selector":"L1248-L1259","symbol":"Model._do_insert"}`

## Items

```json
[
  {
    "text": "Do an INSERT. If returning_fields is defined then this method should return the newly created data for the model.",
    "locator": {
      "line": 1249
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._do_insert](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1259,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1248,
    "symbol": "Model._do_insert"
  },
  "id": "038be281-26e7-4f4e-b09e-aef807582767",
  "items": [
    {
      "locator": {
        "line": 1249
      },
      "text": "Do an INSERT. If returning_fields is defined then this method should return the newly created data for the model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3422020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1248,
        "selector": "L1248-L1259",
        "symbol": "Model._do_insert"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "30b2af3f-abb5-43cc-b3ff-249759c03334",
  "subject_name": "django/db/models/base::Model._do_insert",
  "tags": [
    "entity:method"
  ],
  "text": "def _do_insert(self, manager, using, fields, returning_fields, raw)"
}
```
