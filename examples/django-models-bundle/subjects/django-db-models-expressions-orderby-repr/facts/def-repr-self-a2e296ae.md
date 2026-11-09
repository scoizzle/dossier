# Fact a2e296ae

Store id: e2f68c4c-ad11-4e07-a64e-39c49bc2e973

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
- posted_at: `2026-11-09T23:44:49.6537910+00:00`

## Data

```json
{
  "end_line": 1936,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 1933,
  "symbol": "OrderBy.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1933,"selector":"L1933-L1936","symbol":"OrderBy.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1936,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 1933,
    "symbol": "OrderBy.__repr__"
  },
  "id": "e2f68c4c-ad11-4e07-a64e-39c49bc2e973",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6537910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1933,
        "selector": "L1933-L1936",
        "symbol": "OrderBy.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f0758f78-88df-4fc0-866c-b48c4d3d9a8e",
  "subject_name": "django/db/models/expressions::OrderBy.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
