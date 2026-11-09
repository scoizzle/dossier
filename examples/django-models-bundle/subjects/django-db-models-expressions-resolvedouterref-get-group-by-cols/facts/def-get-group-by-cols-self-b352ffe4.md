# Fact b352ffe4

Store id: 7205044e-8ebd-4237-b9f8-aa6d30a4cf7c

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T23:31:55.8444000+00:00`

## Data

```json
{
  "end_line": 980,
  "entity_kind": "method",
  "parent": "ResolvedOuterRef",
  "start_line": 979,
  "symbol": "ResolvedOuterRef.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":979,"selector":"L979-L980","symbol":"ResolvedOuterRef.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ResolvedOuterRef.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 980,
    "entity_kind": "method",
    "parent": "ResolvedOuterRef",
    "start_line": 979,
    "symbol": "ResolvedOuterRef.get_group_by_cols"
  },
  "id": "7205044e-8ebd-4237-b9f8-aa6d30a4cf7c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8444000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 979,
        "selector": "L979-L980",
        "symbol": "ResolvedOuterRef.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8fcef662-9f74-4631-8a51-c9d201f22f6c",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
