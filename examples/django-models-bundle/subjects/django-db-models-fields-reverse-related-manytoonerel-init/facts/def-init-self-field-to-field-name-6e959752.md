# Fact 6e959752

Store id: 752865c8-0e27-41d0-92eb-b96bf9305839

## Text

```text
def __init__( self, field, to, field_name, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )
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
- posted_at: `2026-11-09T23:44:52.5078640+00:00`

## Data

```json
{
  "end_line": 287,
  "entity_kind": "method",
  "parent": "ManyToOneRel",
  "start_line": 266,
  "symbol": "ManyToOneRel.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":266,"selector":"L266-L287","symbol":"ManyToOneRel.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToOneRel.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 287,
    "entity_kind": "method",
    "parent": "ManyToOneRel",
    "start_line": 266,
    "symbol": "ManyToOneRel.__init__"
  },
  "id": "752865c8-0e27-41d0-92eb-b96bf9305839",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.5078640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 266,
        "selector": "L266-L287",
        "symbol": "ManyToOneRel.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "9b651e1d-742a-4766-8529-c7eb7ae9b926",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, field, to, field_name, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, )"
}
```
