# Fact 4af23eed

Store id: c2cfaba5-afa9-416f-b0bf-0da32b751034

## Text

```text
def __init__( self, to, on_delete, from_fields, to_fields, rel=None, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, swappable=True, **kwargs, )
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
- posted_at: `2026-11-09T23:31:58.6616490+00:00`

## Data

```json
{
  "end_line": 595,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 560,
  "symbol": "ForeignObject.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":560,"selector":"L560-L595","symbol":"ForeignObject.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 595,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 560,
    "symbol": "ForeignObject.__init__"
  },
  "id": "c2cfaba5-afa9-416f-b0bf-0da32b751034",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6616490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 560,
        "selector": "L560-L595",
        "symbol": "ForeignObject.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "961c7b9d-1a0d-48c5-8fcb-1883f964c9f5",
  "subject_name": "django/db/models/fields/related::ForeignObject.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, to, on_delete, from_fields, to_fields, rel=None, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, swappable=True, **kwargs, )"
}
```
