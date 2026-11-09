# Fact 5b47d4cf

Store id: e8f23c09-e9a3-496b-8087-fd83c66dbfe8

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
- posted_at: `2026-11-09T22:39:46.1470580+00:00`

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
  "id": "e8f23c09-e9a3-496b-8087-fd83c66dbfe8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1470580+00:00"
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
  "subject_id": "2b14f583-1a0b-4c3c-9526-99b4ec2282b9",
  "subject_name": "django/db/models/functions/datetime::ExtractQuarter",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractQuarter(Extract)"
}
```
