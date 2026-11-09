# Fact 7799b99d

Store id: 70b5bd4e-28e8-4bbf-a6f3-6485b72c136e

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T22:39:50.0948630+00:00`

## Data

```json
{
  "end_line": 213,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 203,
  "symbol": "Q.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":203,"selector":"L203-L213","symbol":"Q.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 213,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 203,
    "symbol": "Q.deconstruct"
  },
  "id": "70b5bd4e-28e8-4bbf-a6f3-6485b72c136e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0948630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 203,
        "selector": "L203-L213",
        "symbol": "Q.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "ec41b1f9-a7bd-4e29-a00c-55c0ac732b1d",
  "subject_name": "django/db/models/query_utils::Q.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
