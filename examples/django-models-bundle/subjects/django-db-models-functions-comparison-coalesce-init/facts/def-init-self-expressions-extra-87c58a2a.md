# Fact 87c58a2a

Store id: 7d37397b-75ea-4e50-ac8e-e7d87ae81366

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
- posted_at: `2026-11-09T23:44:53.1360820+00:00`

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
  "id": "7d37397b-75ea-4e50-ac8e-e7d87ae81366",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1360820+00:00"
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
  "subject_id": "b42d6f4c-ece2-4382-b72c-304ef9bcc550",
  "subject_name": "django/db/models/functions/comparison::Coalesce.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```
