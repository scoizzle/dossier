# Fact 12d8845f

Store id: d98217d5-3c2e-4685-b8c1-4571b2c02ead

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
- posted_at: `2026-11-09T22:39:41.5694720+00:00`

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
  "id": "d98217d5-3c2e-4685-b8c1-4571b2c02ead",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5694720+00:00"
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
  "subject_id": "8d487006-cc1f-4ce6-a17f-c4989254c53c",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
