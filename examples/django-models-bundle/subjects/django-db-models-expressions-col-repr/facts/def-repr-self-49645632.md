# Fact 49645632

Store id: 11e94ee0-5db9-4c03-89c9-11b0db8ca50e

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:41.6303000+00:00`

## Data

```json
{
  "end_line": 1364,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1361,
  "symbol": "Col.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1361,"selector":"L1361-L1364","symbol":"Col.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1364,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1361,
    "symbol": "Col.__repr__"
  },
  "id": "11e94ee0-5db9-4c03-89c9-11b0db8ca50e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6303000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1361,
        "selector": "L1361-L1364",
        "symbol": "Col.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2b1728e7-411c-476e-b804-4a32bbb0f0a0",
  "subject_name": "django/db/models/expressions::Col.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
