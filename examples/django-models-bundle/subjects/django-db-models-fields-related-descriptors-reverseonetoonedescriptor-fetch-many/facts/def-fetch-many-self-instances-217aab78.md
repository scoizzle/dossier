# Fact 217aab78

Store id: 6d7057af-00fa-404a-a4a6-22117d5a47f9

## Text

```text
def fetch_many(self, instances)
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
- posted_at: `2026-11-09T22:39:44.7630340+00:00`

## Data

```json
{
  "end_line": 577,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 571,
  "symbol": "ReverseOneToOneDescriptor.fetch_many"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":571,"selector":"L571-L577","symbol":"ReverseOneToOneDescriptor.fetch_many"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.fetch_many](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 577,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 571,
    "symbol": "ReverseOneToOneDescriptor.fetch_many"
  },
  "id": "6d7057af-00fa-404a-a4a6-22117d5a47f9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7630340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 571,
        "selector": "L571-L577",
        "symbol": "ReverseOneToOneDescriptor.fetch_many"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "a19d737c-27f7-4e9b-a405-9013524d11a3",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.fetch_many",
  "tags": [
    "entity:method"
  ],
  "text": "def fetch_many(self, instances)"
}
```
