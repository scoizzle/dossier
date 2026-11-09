# Fact ad52351e

Store id: 37fc4645-b5db-4405-b920-68c01276b290

## Text

```text
def __rand__(self, other)
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
- posted_at: `2026-11-09T23:31:55.7515350+00:00`

## Data

```json
{
  "end_line": 154,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 151,
  "symbol": "Combinable.__rand__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":151,"selector":"L151-L154","symbol":"Combinable.__rand__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rand__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 154,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 151,
    "symbol": "Combinable.__rand__"
  },
  "id": "37fc4645-b5db-4405-b920-68c01276b290",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7515350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 151,
        "selector": "L151-L154",
        "symbol": "Combinable.__rand__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ff4d7fb8-6b41-4c40-95b3-0f834ace70b5",
  "subject_name": "django/db/models/expressions::Combinable.__rand__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rand__(self, other)"
}
```
