# Fact 04a5da38

Store id: 706274ea-7dde-4a14-9dc4-f8733025f172

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
- posted_at: `2026-11-09T23:31:58.7404290+00:00`

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
  "id": "706274ea-7dde-4a14-9dc4-f8733025f172",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7404290+00:00"
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
  "subject_id": "a1089521-7598-4f68-b4b5-bae86c38a0e3",
  "subject_name": "django/db/models/fields/related::ForeignKey.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, to, on_delete, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, to_field=None, db_constraint=True, **kwargs, )"
}
```
