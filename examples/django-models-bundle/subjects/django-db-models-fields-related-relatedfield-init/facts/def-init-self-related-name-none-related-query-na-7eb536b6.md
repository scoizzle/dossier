# Fact 7eb536b6

Store id: 83443197-133d-4091-b687-5c871425b7d7

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
- posted_at: `2026-11-09T23:31:58.5991970+00:00`

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
  "id": "83443197-133d-4091-b687-5c871425b7d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.5991970+00:00"
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
  "subject_id": "4af0ea1a-d28c-48f3-8607-bed44358c2ff",
  "subject_name": "django/db/models/fields/related::RelatedField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, related_name=None, related_query_name=None, limit_choices_to=None, **kwargs, )"
}
```
