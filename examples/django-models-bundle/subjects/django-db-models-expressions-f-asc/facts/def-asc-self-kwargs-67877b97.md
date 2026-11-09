# Fact 67877b97

Store id: 5610973d-19f9-4168-9341-0176801b8652

## Text

```text
def asc(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:41.5632640+00:00`

## Data

```json
{
  "end_line": 931,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 930,
  "symbol": "F.asc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":930,"selector":"L930-L931","symbol":"F.asc"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.asc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 931,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 930,
    "symbol": "F.asc"
  },
  "id": "5610973d-19f9-4168-9341-0176801b8652",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5632640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 930,
        "selector": "L930-L931",
        "symbol": "F.asc"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2009c010-8d34-40e5-b1a2-fba515187197",
  "subject_name": "django/db/models/expressions::F.asc",
  "tags": [
    "entity:method"
  ],
  "text": "def asc(self, **kwargs)"
}
```
