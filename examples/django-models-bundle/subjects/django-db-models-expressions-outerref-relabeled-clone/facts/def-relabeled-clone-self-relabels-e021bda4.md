# Fact e021bda4

Store id: f4bb4c00-e300-44c1-aedb-72d503ea0e67

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
- posted_at: `2026-11-09T22:39:41.5726750+00:00`

## Data

```json
{
  "end_line": 993,
  "entity_kind": "method",
  "parent": "OuterRef",
  "start_line": 992,
  "symbol": "OuterRef.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":992,"selector":"L992-L993","symbol":"OuterRef.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OuterRef.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 993,
    "entity_kind": "method",
    "parent": "OuterRef",
    "start_line": 992,
    "symbol": "OuterRef.relabeled_clone"
  },
  "id": "f4bb4c00-e300-44c1-aedb-72d503ea0e67",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5726750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 992,
        "selector": "L992-L993",
        "symbol": "OuterRef.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "651b035a-56e8-46be-a6fe-b0c783ededef",
  "subject_name": "django/db/models/expressions::OuterRef.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
