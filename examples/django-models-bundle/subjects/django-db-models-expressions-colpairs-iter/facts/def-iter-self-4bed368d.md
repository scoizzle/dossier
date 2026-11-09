# Fact 4bed368d

Store id: 0c08729e-62aa-40d4-bbf3-abf45b9c5952

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T22:39:41.6397720+00:00`

## Data

```json
{
  "end_line": 1401,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1400,
  "symbol": "ColPairs.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1400,"selector":"L1400-L1401","symbol":"ColPairs.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1401,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1400,
    "symbol": "ColPairs.__iter__"
  },
  "id": "0c08729e-62aa-40d4-bbf3-abf45b9c5952",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6397720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1400,
        "selector": "L1400-L1401",
        "symbol": "ColPairs.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0e028bfb-138b-4315-89de-833af86987eb",
  "subject_name": "django/db/models/expressions::ColPairs.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
