# Fact 53775685

Store id: 0b9030d0-e359-4776-9888-eb1fc22041b5

## Text

```text
class StartsWith(PatternLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:Field.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.3642160+00:00`

## Data

```json
{
  "end_line": 638,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 635,
  "symbol": "StartsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":635,"selector":"L635-L638","symbol":"StartsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::StartsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 638,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 635,
    "symbol": "StartsWith"
  },
  "id": "0b9030d0-e359-4776-9888-eb1fc22041b5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3642160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 635,
        "selector": "L635-L638",
        "symbol": "StartsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "2d8d61f6-11b1-4c46-b863-42777044c360",
  "subject_name": "django/db/models/lookups::StartsWith",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class StartsWith(PatternLookup)"
}
```
