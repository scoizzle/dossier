# Fact 3e994976

Store id: fb9c745a-acfd-4f3b-91f2-66dcd3cc7d11

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
- posted_at: `2026-11-09T23:44:55.0195740+00:00`

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
  "id": "fb9c745a-acfd-4f3b-91f2-66dcd3cc7d11",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0195740+00:00"
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
  "subject_id": "8f495b2d-024a-4532-8f60-747abfc02164",
  "subject_name": "django/db/models/lookups::PatternLookup.is_simple_lookup",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def is_simple_lookup(self)"
}
```
