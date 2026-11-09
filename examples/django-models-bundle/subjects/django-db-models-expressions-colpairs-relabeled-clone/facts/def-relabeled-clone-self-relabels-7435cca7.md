# Fact 7435cca7

Store id: 3303ac7f-a9d7-4361-8b8f-65e220c018b6

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
- posted_at: `2026-11-09T23:44:49.5678200+00:00`

## Data

```json
{
  "end_line": 1438,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1435,
  "symbol": "ColPairs.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1435,"selector":"L1435-L1438","symbol":"ColPairs.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1438,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1435,
    "symbol": "ColPairs.relabeled_clone"
  },
  "id": "3303ac7f-a9d7-4361-8b8f-65e220c018b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5678200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1435,
        "selector": "L1435-L1438",
        "symbol": "ColPairs.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d7bf35ee-5eeb-43ea-b921-4a52e6f49b5f",
  "subject_name": "django/db/models/expressions::ColPairs.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
