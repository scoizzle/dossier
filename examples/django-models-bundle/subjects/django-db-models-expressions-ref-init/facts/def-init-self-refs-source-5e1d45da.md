# Fact 5e1d45da

Store id: 05c330fa-3561-4fd6-8a70-42a1885dbde1

## Text

```text
def __init__(self, refs, source)
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
- posted_at: `2026-11-09T22:39:41.6499920+00:00`

## Data

```json
{
  "end_line": 1455,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1453,
  "symbol": "Ref.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1453,"selector":"L1453-L1455","symbol":"Ref.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1455,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1453,
    "symbol": "Ref.__init__"
  },
  "id": "05c330fa-3561-4fd6-8a70-42a1885dbde1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6499920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1453,
        "selector": "L1453-L1455",
        "symbol": "Ref.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a87ef703-5bb3-498a-b1c3-900d3a19d2bf",
  "subject_name": "django/db/models/expressions::Ref.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, refs, source)"
}
```
