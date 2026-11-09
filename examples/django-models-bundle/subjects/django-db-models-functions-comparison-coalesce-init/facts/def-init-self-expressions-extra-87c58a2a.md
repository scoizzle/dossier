# Fact 87c58a2a

Store id: 265f0d2b-0652-433e-aad6-9aa4917fca35

## Text

```text
def __init__(self, *expressions, **extra)
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
- posted_at: `2026-11-09T23:32:00.9670430+00:00`

## Data

```json
{
  "end_line": 78,
  "entity_kind": "method",
  "parent": "Coalesce",
  "start_line": 75,
  "symbol": "Coalesce.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":75,"selector":"L75-L78","symbol":"Coalesce.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Coalesce.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 78,
    "entity_kind": "method",
    "parent": "Coalesce",
    "start_line": 75,
    "symbol": "Coalesce.__init__"
  },
  "id": "265f0d2b-0652-433e-aad6-9aa4917fca35",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9670430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 75,
        "selector": "L75-L78",
        "symbol": "Coalesce.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "f03ceedd-c9df-4244-9d99-e0fe15aa33c6",
  "subject_name": "django/db/models/functions/comparison::Coalesce.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```
