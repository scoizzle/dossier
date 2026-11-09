# Fact 0c1fc37f

Store id: 0006d479-eb95-427e-a43c-923bb7ce3c75

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:32:04.8134210+00:00`

## Data

```json
{
  "end_line": 2631,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2630,
  "symbol": "Prefetch.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2630,"selector":"L2630-L2631","symbol":"Prefetch.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2631,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2630,
    "symbol": "Prefetch.__hash__"
  },
  "id": "0006d479-eb95-427e-a43c-923bb7ce3c75",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8134210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2630,
        "selector": "L2630-L2631",
        "symbol": "Prefetch.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "fad5f3e7-d454-4885-9832-c9b5760dcfb5",
  "subject_name": "django/db/models/query::Prefetch.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
