# Fact 12d8845f

Store id: 49df05f2-58df-4914-8a76-c898ec2ae84a

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
- posted_at: `2026-11-09T23:31:55.8436670+00:00`

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
  "id": "49df05f2-58df-4914-8a76-c898ec2ae84a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8436670+00:00"
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
  "subject_id": "924b855d-0d70-47aa-b775-18438b8e4602",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
