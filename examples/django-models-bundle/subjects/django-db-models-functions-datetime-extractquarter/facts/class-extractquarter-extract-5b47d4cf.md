# Fact 5b47d4cf

Store id: cd4bb139-01c0-4b74-8913-bf58b7de6ca4

## Text

```text
class ExtractQuarter(Extract)
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
- posted_at: `2026-11-09T23:32:01.2161580+00:00`

## Data

```json
{
  "end_line": 168,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 167,
  "symbol": "ExtractQuarter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":167,"selector":"L167-L168","symbol":"ExtractQuarter"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractQuarter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 168,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 167,
    "symbol": "ExtractQuarter"
  },
  "id": "cd4bb139-01c0-4b74-8913-bf58b7de6ca4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2161580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 167,
        "selector": "L167-L168",
        "symbol": "ExtractQuarter"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "393e7bf5-9512-4093-ac6e-0a1b13777d10",
  "subject_name": "django/db/models/functions/datetime::ExtractQuarter",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractQuarter(Extract)"
}
```
