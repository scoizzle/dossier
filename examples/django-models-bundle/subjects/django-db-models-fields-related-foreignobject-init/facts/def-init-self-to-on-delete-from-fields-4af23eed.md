# Fact 4af23eed

Store id: 17b64e38-46ac-495c-b758-71a097c26331

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
- posted_at: `2026-11-09T22:39:44.3068070+00:00`

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
  "id": "17b64e38-46ac-495c-b758-71a097c26331",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3068070+00:00"
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
  "subject_id": "aba95ee1-9851-4475-a9b2-1add931a3fb5",
  "subject_name": "django/db/models/fields/related::ForeignObject.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, to, on_delete, from_fields, to_fields, rel=None, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, swappable=True, **kwargs, )"
}
```
