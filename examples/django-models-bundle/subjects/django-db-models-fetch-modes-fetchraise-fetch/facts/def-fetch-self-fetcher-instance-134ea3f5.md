# Fact 134ea3f5

Store id: 09621af5-0d16-4c3a-9564-524196a3b231

## Text

```text
def fetch(self, fetcher, instance)
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
- posted_at: `2026-11-09T23:31:56.2286250+00:00`

## Data

```json
{
  "end_line": 55,
  "entity_kind": "method",
  "parent": "FetchRaise",
  "start_line": 52,
  "symbol": "FetchRaise.fetch"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":52,"selector":"L52-L55","symbol":"FetchRaise.fetch"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchRaise.fetch](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 55,
    "entity_kind": "method",
    "parent": "FetchRaise",
    "start_line": 52,
    "symbol": "FetchRaise.fetch"
  },
  "id": "09621af5-0d16-4c3a-9564-524196a3b231",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.2286250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 52,
        "selector": "L52-L55",
        "symbol": "FetchRaise.fetch"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "840fdab4-9ce4-4753-b0d6-551e2001901b",
  "subject_name": "django/db/models/fetch_modes::FetchRaise.fetch",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch(self, fetcher, instance)"
}
```
