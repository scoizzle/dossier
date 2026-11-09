# Fact 04a5da38

Store id: e5ad3fb4-2294-456d-84de-b623cb220ab0

## Text

```text
def __init__( self, to, on_delete, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, to_field=None, db_constraint=True, **kwargs, )
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
- posted_at: `2026-11-09T22:39:44.3692500+00:00`

## Data

```json
{
  "end_line": 1051,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 996,
  "symbol": "ForeignKey.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":996,"selector":"L996-L1051","symbol":"ForeignKey.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1051,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 996,
    "symbol": "ForeignKey.__init__"
  },
  "id": "e5ad3fb4-2294-456d-84de-b623cb220ab0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3692500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 996,
        "selector": "L996-L1051",
        "symbol": "ForeignKey.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "e3eca383-e0f7-42f8-a3e0-f7b89b9dd57e",
  "subject_name": "django/db/models/fields/related::ForeignKey.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, to, on_delete, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, to_field=None, db_constraint=True, **kwargs, )"
}
```
