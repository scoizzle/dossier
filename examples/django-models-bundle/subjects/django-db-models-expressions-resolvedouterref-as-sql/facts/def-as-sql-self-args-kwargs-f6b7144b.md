# Fact f6b7144b

Store id: 47e3d837-7fda-44fd-949d-19af18204f17

## Text

```text
def as_sql(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:31:55.8419060+00:00`

## Data

```json
{
  "end_line": 961,
  "entity_kind": "method",
  "parent": "ResolvedOuterRef",
  "start_line": 957,
  "symbol": "ResolvedOuterRef.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":957,"selector":"L957-L961","symbol":"ResolvedOuterRef.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ResolvedOuterRef.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 961,
    "entity_kind": "method",
    "parent": "ResolvedOuterRef",
    "start_line": 957,
    "symbol": "ResolvedOuterRef.as_sql"
  },
  "id": "47e3d837-7fda-44fd-949d-19af18204f17",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8419060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 957,
        "selector": "L957-L961",
        "symbol": "ResolvedOuterRef.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "da57416c-c981-409f-834f-06afe7f13e53",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, *args, **kwargs)"
}
```
