# Fact d6d4279c

Store id: 747e5306-d9b2-4c26-a4a9-478f07b1edd5

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
- posted_at: `2026-11-09T23:44:55.5781160+00:00`

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
  "id": "747e5306-d9b2-4c26-a4a9-478f07b1edd5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5781160+00:00"
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
  "subject_id": "5811e65d-0bb8-4f5f-a113-d50f312318cb",
  "subject_name": "django/db/models/options::Options._expire_cache",
  "tags": [
    "entity:method"
  ],
  "text": "def _expire_cache(self, forward=True, reverse=True)"
}
```
