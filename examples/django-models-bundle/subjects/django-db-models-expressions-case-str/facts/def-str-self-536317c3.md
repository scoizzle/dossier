# Fact 536317c3

Store id: 7b837bc7-6afb-4211-b2cf-6118a0c737da

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:44:49.6241860+00:00`

## Data

```json
{
  "end_line": 1745,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1741,
  "symbol": "Case.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1741,"selector":"L1741-L1745","symbol":"Case.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1745,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1741,
    "symbol": "Case.__str__"
  },
  "id": "7b837bc7-6afb-4211-b2cf-6118a0c737da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6241860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1741,
        "selector": "L1741-L1745",
        "symbol": "Case.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "508d3e0b-870c-4474-a237-f691431817ac",
  "subject_name": "django/db/models/expressions::Case.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
