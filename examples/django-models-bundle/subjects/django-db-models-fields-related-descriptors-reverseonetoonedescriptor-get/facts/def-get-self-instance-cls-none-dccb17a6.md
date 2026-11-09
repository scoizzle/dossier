# Fact dccb17a6

Store id: c722b300-c1d2-4223-b3d2-afdb4c426ee8

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
- posted_at: `2026-11-09T23:44:51.8764300+00:00`

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
  "id": "c722b300-c1d2-4223-b3d2-afdb4c426ee8",
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
    "posted_at": "2026-11-09T23:44:51.8764300+00:00"
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
  "subject_id": "7cba3df0-fe82-42cd-8ef7-5d43740d86cd",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
