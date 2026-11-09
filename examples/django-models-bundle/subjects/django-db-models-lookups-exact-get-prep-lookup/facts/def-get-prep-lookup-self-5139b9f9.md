# Fact 5139b9f9

Store id: fc51f033-f97f-47bd-a5ee-6d9ee2fe06de

## Text

```text
def get_prep_lookup(self)
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
- posted_at: `2026-11-09T23:32:03.2541230+00:00`

## Data

```json
{
  "end_line": 394,
  "entity_kind": "method",
  "parent": "Exact",
  "start_line": 376,
  "symbol": "Exact.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":376,"selector":"L376-L394","symbol":"Exact.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Exact.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 394,
    "entity_kind": "method",
    "parent": "Exact",
    "start_line": 376,
    "symbol": "Exact.get_prep_lookup"
  },
  "id": "fc51f033-f97f-47bd-a5ee-6d9ee2fe06de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2541230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 376,
        "selector": "L376-L394",
        "symbol": "Exact.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f927493a-b4fd-4079-9929-3f46ed2b6bc5",
  "subject_name": "django/db/models/lookups::Exact.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
