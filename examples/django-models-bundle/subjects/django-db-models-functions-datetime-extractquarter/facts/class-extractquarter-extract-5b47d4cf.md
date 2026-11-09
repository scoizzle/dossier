# Fact 5b47d4cf

Store id: edc46f46-c4e4-43ca-98af-3801b4e275cc

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
- posted_at: `2026-11-09T23:44:53.3556040+00:00`

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
  "id": "edc46f46-c4e4-43ca-98af-3801b4e275cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3556040+00:00"
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
  "subject_id": "8f0c2b59-0bc7-409a-966a-e18b44e228ae",
  "subject_name": "django/db/models/functions/datetime::ExtractQuarter",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractQuarter(Extract)"
}
```
