# Fact 3e994976

Store id: fd243751-9b0d-4c6d-a27e-1b03282b0199

## Text

```text
def is_simple_lookup(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.3520300+00:00`

## Data

```json
{
  "end_line": 622,
  "entity_kind": "method",
  "parent": "PatternLookup",
  "start_line": 618,
  "symbol": "PatternLookup.is_simple_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":618,"selector":"L618-L622","symbol":"PatternLookup.is_simple_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::PatternLookup.is_simple_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 622,
    "entity_kind": "method",
    "parent": "PatternLookup",
    "start_line": 618,
    "symbol": "PatternLookup.is_simple_lookup"
  },
  "id": "fd243751-9b0d-4c6d-a27e-1b03282b0199",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3520300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 618,
        "selector": "L618-L622",
        "symbol": "PatternLookup.is_simple_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "27b5a0bb-91c2-46ab-9aee-9611c09dd52f",
  "subject_name": "django/db/models/lookups::PatternLookup.is_simple_lookup",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def is_simple_lookup(self)"
}
```
