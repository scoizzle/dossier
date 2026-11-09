# Fact 134ea3f5

Store id: b438e39f-cf2f-4d1c-98cb-55b414311d2f

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
- posted_at: `2026-11-09T22:39:42.0118500+00:00`

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
  "id": "b438e39f-cf2f-4d1c-98cb-55b414311d2f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.0118500+00:00"
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
  "subject_id": "cd9dae33-0c64-4e30-9160-27eaf1abe1b4",
  "subject_name": "django/db/models/fetch_modes::FetchRaise.fetch",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch(self, fetcher, instance)"
}
```
