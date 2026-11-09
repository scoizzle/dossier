# Fact 1a0cf011

Store id: 775d9017-5d87-48fd-8dee-95f997622bb1

## Text

```text
class Deferred
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.7041140+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "class",
  "parent": "base",
  "start_line": 61,
  "symbol": "Deferred"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":61,"selector":"L61-L66","symbol":"Deferred"}`

## Referenced by

None.

## Subject

[django/db/models/base::Deferred](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "class",
    "parent": "base",
    "start_line": 61,
    "symbol": "Deferred"
  },
  "id": "775d9017-5d87-48fd-8dee-95f997622bb1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7041140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 61,
        "selector": "L61-L66",
        "symbol": "Deferred"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "430df230-56ea-4c57-bf91-0dd944479b26",
  "subject_name": "django/db/models/base::Deferred",
  "tags": [
    "entity:class"
  ],
  "text": "class Deferred"
}
```
