# Fact a2bbc3d0

Store id: 4d74bf72-ca1b-47ed-ab16-0e8181d401fb

## Text

```text
def resolve_expression(self, query, reuse, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:56.7611590+00:00`

## Data

```json
{
  "end_line": 567,
  "entity_kind": "method",
  "parent": "FilteredRelation",
  "start_line": 558,
  "symbol": "FilteredRelation.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":558,"selector":"L558-L567","symbol":"FilteredRelation.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 567,
    "entity_kind": "method",
    "parent": "FilteredRelation",
    "start_line": 558,
    "symbol": "FilteredRelation.resolve_expression"
  },
  "id": "4d74bf72-ca1b-47ed-ab16-0e8181d401fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.7611590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 558,
        "selector": "L558-L567",
        "symbol": "FilteredRelation.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "56d5c52b-4c1a-444c-86c2-6f6da9014442",
  "subject_name": "django/db/models/query_utils::FilteredRelation.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, query, reuse, *args, **kwargs)"
}
```
