# Fact 904ce167

Store id: e431c934-e496-43b6-84c5-3fa4e89f8e43

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
- posted_at: `2026-11-09T22:39:42.0003170+00:00`

## Data

```json
{
  "end_line": 40,
  "entity_kind": "method",
  "parent": "FetchPeers",
  "start_line": 31,
  "symbol": "FetchPeers.fetch"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":31,"selector":"L31-L40","symbol":"FetchPeers.fetch"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchPeers.fetch](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 40,
    "entity_kind": "method",
    "parent": "FetchPeers",
    "start_line": 31,
    "symbol": "FetchPeers.fetch"
  },
  "id": "e431c934-e496-43b6-84c5-3fa4e89f8e43",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.0003170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 31,
        "selector": "L31-L40",
        "symbol": "FetchPeers.fetch"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "fb0446d7-7903-454f-8000-985f40bad494",
  "subject_name": "django/db/models/fetch_modes::FetchPeers.fetch",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch(self, fetcher, instance)"
}
```
