# Fact 3067761f

Store id: ea622a47-cc3c-4d69-a339-ab3fc2a88e8d

## Text

```text
class YearGt(YearLookup, GreaterThan)
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
- posted_at: `2026-11-09T22:39:48.2447560+00:00`

## Data

```json
{
  "end_line": 763,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 761,
  "symbol": "YearGt"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":761,"selector":"L761-L763","symbol":"YearGt"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearGt](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 763,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 761,
    "symbol": "YearGt"
  },
  "id": "ea622a47-cc3c-4d69-a339-ab3fc2a88e8d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2447560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 761,
        "selector": "L761-L763",
        "symbol": "YearGt"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e029f38c-ebfc-49d4-901a-6aace97d90c1",
  "subject_name": "django/db/models/lookups::YearGt",
  "tags": [
    "entity:class"
  ],
  "text": "class YearGt(YearLookup, GreaterThan)"
}
```
