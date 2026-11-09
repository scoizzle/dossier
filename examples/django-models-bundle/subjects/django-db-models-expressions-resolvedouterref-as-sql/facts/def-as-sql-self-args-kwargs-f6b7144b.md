# Fact f6b7144b

Store id: 490812a4-0870-4e10-a57f-206d35c6c5de

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
- posted_at: `2026-11-09T22:39:41.5680900+00:00`

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
  "id": "490812a4-0870-4e10-a57f-206d35c6c5de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5680900+00:00"
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
  "subject_id": "b8612876-9556-47a9-8e5f-e1e7b4181661",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, *args, **kwargs)"
}
```
