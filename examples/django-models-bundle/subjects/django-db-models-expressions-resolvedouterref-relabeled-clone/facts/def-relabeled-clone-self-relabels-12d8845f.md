# Fact 12d8845f

Store id: 87990025-1411-423b-ba3d-5d9dceadb9a1

## Text

```text
def relabeled_clone(self, relabels)
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
- posted_at: `2026-11-09T23:44:49.4917520+00:00`

## Data

```json
{
  "end_line": 977,
  "entity_kind": "method",
  "parent": "ResolvedOuterRef",
  "start_line": 976,
  "symbol": "ResolvedOuterRef.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":976,"selector":"L976-L977","symbol":"ResolvedOuterRef.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ResolvedOuterRef.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 977,
    "entity_kind": "method",
    "parent": "ResolvedOuterRef",
    "start_line": 976,
    "symbol": "ResolvedOuterRef.relabeled_clone"
  },
  "id": "87990025-1411-423b-ba3d-5d9dceadb9a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4917520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 976,
        "selector": "L976-L977",
        "symbol": "ResolvedOuterRef.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4ed82a89-354c-4939-be7a-bbbb66bcfaf0",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
