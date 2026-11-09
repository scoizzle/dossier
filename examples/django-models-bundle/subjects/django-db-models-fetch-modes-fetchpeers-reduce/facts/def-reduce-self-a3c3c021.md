# Fact a3c3c021

Store id: ca1f2463-83fd-4630-b43e-8eeaaf8b93be

## Text

```text
def __reduce__(self)
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
- posted_at: `2026-11-09T23:44:49.8171560+00:00`

## Data

```json
{
  "end_line": 43,
  "entity_kind": "method",
  "parent": "FetchPeers",
  "start_line": 42,
  "symbol": "FetchPeers.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":42,"selector":"L42-L43","symbol":"FetchPeers.__reduce__"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchPeers.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 43,
    "entity_kind": "method",
    "parent": "FetchPeers",
    "start_line": 42,
    "symbol": "FetchPeers.__reduce__"
  },
  "id": "ca1f2463-83fd-4630-b43e-8eeaaf8b93be",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.8171560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 42,
        "selector": "L42-L43",
        "symbol": "FetchPeers.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "b66069a9-4bda-4758-8822-f508cf0f81d4",
  "subject_name": "django/db/models/fetch_modes::FetchPeers.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
