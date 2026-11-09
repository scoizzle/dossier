# Fact d6d4279c

Store id: 1486d006-d917-4fd0-a725-a6e8d1d49111

## Text

```text
def _expire_cache(self, forward=True, reverse=True)
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
- posted_at: `2026-11-09T22:39:48.9376810+00:00`

## Data

```json
{
  "end_line": 863,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 852,
  "symbol": "Options._expire_cache"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":852,"selector":"L852-L863","symbol":"Options._expire_cache"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options._expire_cache](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 863,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 852,
    "symbol": "Options._expire_cache"
  },
  "id": "1486d006-d917-4fd0-a725-a6e8d1d49111",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.9376810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 852,
        "selector": "L852-L863",
        "symbol": "Options._expire_cache"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "0dcfd9a2-2af8-4c97-adf7-681eb4b81344",
  "subject_name": "django/db/models/options::Options._expire_cache",
  "tags": [
    "entity:method"
  ],
  "text": "def _expire_cache(self, forward=True, reverse=True)"
}
```
