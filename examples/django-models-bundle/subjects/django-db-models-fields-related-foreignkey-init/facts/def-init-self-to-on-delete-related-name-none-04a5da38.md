# Fact 04a5da38

Store id: ffcf2397-b15f-414c-9fac-283620728b51

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
- posted_at: `2026-11-09T23:44:51.5646550+00:00`

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
  "id": "ffcf2397-b15f-414c-9fac-283620728b51",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5646550+00:00"
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
  "subject_id": "ec3354e7-55a8-483e-b4f5-958d22500772",
  "subject_name": "django/db/models/fields/related::ForeignKey.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, to, on_delete, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, to_field=None, db_constraint=True, **kwargs, )"
}
```
