# Fact 76785b72

Store id: 7610d056-0e42-4885-883c-3bd40a32f392

## Text

```text
class PatternLookup(BuiltinLookup)
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
- posted_at: `2026-11-09T23:44:55.0129170+00:00`

## Data

```json
{
  "end_line": 622,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 584,
  "symbol": "PatternLookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":584,"selector":"L584-L622","symbol":"PatternLookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::PatternLookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 622,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 584,
    "symbol": "PatternLookup"
  },
  "id": "7610d056-0e42-4885-883c-3bd40a32f392",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0129170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 584,
        "selector": "L584-L622",
        "symbol": "PatternLookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "413afc12-afe1-4de6-a096-e9c0d400591f",
  "subject_name": "django/db/models/lookups::PatternLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class PatternLookup(BuiltinLookup)"
}
```
