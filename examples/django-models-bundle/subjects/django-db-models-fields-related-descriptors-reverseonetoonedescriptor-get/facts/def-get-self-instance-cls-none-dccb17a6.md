# Fact dccb17a6

Store id: d95f8693-9772-4056-ab8c-4d0cf31bae97

## Text

```text
def __get__(self, instance, cls=None)
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
- posted_at: `2026-11-09T23:31:59.1958340+00:00`

## Data

```json
{
  "end_line": 549,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 515,
  "symbol": "ReverseOneToOneDescriptor.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":515,"selector":"L515-L549","symbol":"ReverseOneToOneDescriptor.__get__"}`

## Items

```json
[
  {
    "text": "Get the related instance through the reverse relation.",
    "locator": {
      "line": 516
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 549,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 515,
    "symbol": "ReverseOneToOneDescriptor.__get__"
  },
  "id": "d95f8693-9772-4056-ab8c-4d0cf31bae97",
  "items": [
    {
      "locator": {
        "line": 516
      },
      "text": "Get the related instance through the reverse relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1958340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 515,
        "selector": "L515-L549",
        "symbol": "ReverseOneToOneDescriptor.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "4f4aceca-f390-45f6-b579-739a9bfb2d93",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
