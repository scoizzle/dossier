# Fact f6b7144b

Store id: aff7d1ba-09d2-44a4-ac3d-a574b3169ef3

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
- posted_at: `2026-11-09T23:44:49.4901430+00:00`

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
  "id": "aff7d1ba-09d2-44a4-ac3d-a574b3169ef3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4901430+00:00"
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
  "subject_id": "2b51d35f-2f98-4bd9-b2ea-515ce7e57af3",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, *args, **kwargs)"
}
```
