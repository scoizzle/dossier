# Fact c95b4f27

Store id: 3ddc62ef-835d-4e5e-b673-5e7dbc3c5018

## Text

```text
def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )
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
- posted_at: `2026-11-09T23:32:00.2160050+00:00`

## Data

```json
{
  "end_line": 58,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 39,
  "symbol": "ForeignObjectRel.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":39,"selector":"L39-L58","symbol":"ForeignObjectRel.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 58,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 39,
    "symbol": "ForeignObjectRel.__init__"
  },
  "id": "3ddc62ef-835d-4e5e-b673-5e7dbc3c5018",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2160050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 39,
        "selector": "L39-L58",
        "symbol": "ForeignObjectRel.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "23f318f5-1ce9-4492-8dcd-ee2e7934079d",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )"
}
```
