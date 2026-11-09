# Fact 7eb536b6

Store id: 5177637b-dbb0-4f29-8abe-cb46c27dee2e

## Text

```text
def __init__( self, related_name=None, related_query_name=None, limit_choices_to=None, **kwargs, )
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
- posted_at: `2026-11-09T22:39:44.2424220+00:00`

## Data

```json
{
  "end_line": 117,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 107,
  "symbol": "RelatedField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":107,"selector":"L107-L117","symbol":"RelatedField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 117,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 107,
    "symbol": "RelatedField.__init__"
  },
  "id": "5177637b-dbb0-4f29-8abe-cb46c27dee2e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2424220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 107,
        "selector": "L107-L117",
        "symbol": "RelatedField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "706c4d53-de9c-4883-a7aa-45559f238920",
  "subject_name": "django/db/models/fields/related::RelatedField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, related_name=None, related_query_name=None, limit_choices_to=None, **kwargs, )"
}
```
