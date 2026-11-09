# Fact cbd20973

Store id: 25c3b294-15c6-48bd-b378-1f45b5594053

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
- posted_at: `2026-11-09T23:31:56.2174870+00:00`

## Data

```json
{
  "end_line": 17,
  "entity_kind": "method",
  "parent": "FetchOne",
  "start_line": 16,
  "symbol": "FetchOne.fetch"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":16,"selector":"L16-L17","symbol":"FetchOne.fetch"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchOne.fetch](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 17,
    "entity_kind": "method",
    "parent": "FetchOne",
    "start_line": 16,
    "symbol": "FetchOne.fetch"
  },
  "id": "25c3b294-15c6-48bd-b378-1f45b5594053",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.2174870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 16,
        "selector": "L16-L17",
        "symbol": "FetchOne.fetch"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "14ab281b-f802-40e0-b2c3-c47a2d97e926",
  "subject_name": "django/db/models/fetch_modes::FetchOne.fetch",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch(self, fetcher, instance)"
}
```
