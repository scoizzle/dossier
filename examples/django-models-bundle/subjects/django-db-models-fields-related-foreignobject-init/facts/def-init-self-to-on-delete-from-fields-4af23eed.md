# Fact 4af23eed

Store id: f8b179e5-a752-4c45-b97f-e1691dd26ad7

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
- posted_at: `2026-11-09T23:44:51.5127640+00:00`

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
  "id": "f8b179e5-a752-4c45-b97f-e1691dd26ad7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5127640+00:00"
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
  "subject_id": "369bd632-4375-4e2c-aa77-580765c23f58",
  "subject_name": "django/db/models/fields/related::ForeignObject.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, to, on_delete, from_fields, to_fields, rel=None, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, swappable=True, **kwargs, )"
}
```
